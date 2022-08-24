[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Air_Quality_Sensor](../Air_Quality_Sensor.md) > [CO_Sensor](#)
# CO_Sensor

**Display name:** CO Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:CO_Sensor;1

---


## Child interfaces
* [CO_Differential_Sensor](CO_Differential_Sensor.md)
* [CO_Level_Sensor](CO_Level_Sensor.md)
* [Outside_Air_CO_Sensor](Outside_Air_CO_Sensor.md)
* [Return_Air_CO_Sensor](Return_Air_CO_Sensor.md)

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
