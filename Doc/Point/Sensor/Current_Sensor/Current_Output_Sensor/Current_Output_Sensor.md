[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Current_Sensor](../Current_Sensor.md) > [Current_Output_Sensor](#)
# Current_Output_Sensor

**Display name:** Current Output Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Current_Output_Sensor;1

---


## Child interfaces
* [Photovoltaic_Current_Output_Sensor](Photovoltaic_Current_Output_Sensor.md)
* [PV_Current_Output_Sensor](PV_Current_Output_Sensor.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
