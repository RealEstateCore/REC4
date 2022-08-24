[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Enthalpy_Sensor](../Enthalpy_Sensor.md) > [Air_Enthalpy_Sensor](Air_Enthalpy_Sensor.md) > [Outside_Air_Enthalpy_Sensor](.)
# Outside_Air_Enthalpy_Sensor

**Display name:** Outside Air Enthalpy Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Outside_Air_Enthalpy_Sensor;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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
