[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Air_Quality_Sensor](../Air_Quality_Sensor.md) > [CO2_Sensor](.)
# CO2_Sensor

**Display name:** CO2 Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:CO2_Sensor;1

---


## Child interfaces
* [CO2_Differential_Sensor](CO2_Differential_Sensor.md)
* [CO2_Level_Sensor](CO2_Level_Sensor.md)
* [Outside_Air_CO2_Sensor](Outside_Air_CO2_Sensor.md)
* [Return_Air_CO2_Sensor](Return_Air_CO2_Sensor.md)

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
