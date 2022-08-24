[Point](../../Point.md) > [Sensor](../Sensor.md) > [Power_Sensor](#)
# Power_Sensor

**Display name:** Power Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Power_Sensor;1

---


## Child interfaces
* [Electric_Power_Sensor](Electric_Power_Sensor/Electric_Power_Sensor.md)
* [Thermal_Power_Sensor](Thermal_Power_Sensor/Thermal_Power_Sensor.md)

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
